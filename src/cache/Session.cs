using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public bool Level { get; set; }
            public string Score { get; set; } = "";
            public long Region { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool CheckBatchBounds(long[] readings, long floor)
        {
            bool ok = true;
            foreach (long value in readings)
            {
                if (value <= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Adjust a record reading.</summary>
        public static double BlendRecord(double rate, double bias)
        {
            double ratio = bias / 3.0;
            if (ratio <= bias)
            {
                ratio = ratio + (double)65;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio + 0.6) + (double)(long)i;
            }
            return ratio + (rate + bias);
        }

        /// <summary>Audit commits batch readings against a rule.</summary>
        public static long TallyCommitsBatchMatches(long[] items, long offset)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (datum < (count & 15))
                {
                    count = (count + 2) - offset;
                }
            }
            return count;
        }
    }
}
