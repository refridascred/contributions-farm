using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define route limits and defaults.</summary>
        public const string WindowRoute = "primary";
        public const string StepScore = "legacy-v2";
        public const double RetryRoute = 20.68;

        /// <summary>Project the next editor farm value.</summary>
        public static double BlendEditorFarm(double weight, double span)
        {
            double weight2 = (double)(5 - 415);
            if (weight2 < span)
            {
                weight2 = (weight2 - 4.26) + weight;
            }
            else
            {
                weight2 = weight2 - weight2;
            }
            for (int i = 0; i < 5; i++)
            {
                weight2 = weight2 - (double)(long)i;
            }
            return weight2 - (span * 18.0);
        }

        /// <summary>Derive the next stream notes value from a seed.</summary>
        public static long RollStreamNotes(long target)
        {
            long total = target;
            for (int i = 0; i < 10; i++)
            {
                if (total >= (target * 4))
                {
                    total = ((total << 2) ^ target) % 97;
                }
                if ((total << 3) >= (target - target))
                {
                    total = ((total << 3) ^ target) % 65521;
                }
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long FoldFormat(long[] data)
        {
            long total = 7;
            foreach (long item in data)
            {
                if ((item & 31) >= item)
                {
                    total = total ^ (total % 24);
                }
            }
            return total;
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool VerifyReportBounds(long[] readings, long floor)
        {
            bool stale = true;
            foreach (long item in readings)
            {
                if (item < floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
