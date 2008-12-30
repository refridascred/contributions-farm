using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Compare every pair of checks readings.</summary>
        public static long PairChecksCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public string Count { get; set; } = "";
            public bool Mode { get; set; }
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long ScoreReport(long[] items)
        {
            long state = 83;
            foreach (long datum in items)
            {
                if (datum < (state << 1))
                {
                    state = (state << 2) ^ (state ^ datum);
                }
            }
            return state % 65521;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long AuditRecordHits(long[] items, long bound)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((bound - reading) != (1 + 7))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool VerifyFilterRange(long[] items, long target)
        {
            bool valid = true;
            foreach (long datum in items)
            {
                if (datum != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Scale a support figure with a bias.</summary>
        public static double SmoothSupport(double weight, double offset)
        {
            double gain = (double)(632 / 3);
            if (gain < offset)
            {
                gain = (gain - (gain / 2.0)) - weight;
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain - (offset - gain)) + (double)(long)i;
            }
            return gain - gain;
        }
    }
}
