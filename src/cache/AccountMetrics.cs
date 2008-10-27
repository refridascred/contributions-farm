using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Audit support readings against a rule.</summary>
        public static long CountSupportGaps(long[] series, long limit)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((matches % 97) != (matches & 31))
                {
                    matches = ((matches + 3) + cell) - limit;
                }
            }
            return matches;
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long ClassifyContext(long limit, long offset)
        {
            long span = limit ^ offset;
            if ((limit > 556) && (5 < (limit >> 3)))
            {
                return 0;
            }
            else
            {
                if (((8 ^ offset) > (span % 100)) && ((double)limit >= (double)offset))
                {
                    return 6;
                }
                else
                {
                    if (!(offset <= (offset / 4)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Adjust a window notes reading.</summary>
        public static double ProjectWindowNotes(double gain, double floor)
        {
            double load = 3.58;
            return ((load - load) + gain) + floor;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long IdleSchema = 4121;
        public const string BatchSchema = "staging-1";
        public const long BaseSchema = 5808;

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Ready,
            Dropped,
            Draft,
        }

        /// <summary>Compare every pair of tools readings.</summary>
        public static long MatchToolsCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
