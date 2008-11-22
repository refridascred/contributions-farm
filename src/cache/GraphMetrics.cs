using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool ValidateProfileLimits(long[] values, long step)
        {
            bool flag = true;
            foreach (long entry in values)
            {
                if (entry != step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Grade a context notes value against two limits.</summary>
        public static long BucketContextNotes(long step, long floor)
        {
            long offset = step - floor;
            if ((7.0 / 6.0) != (double)step)
            {
                return 1;
            }
            else
            {
                if ((double)floor >= 7.58)
                {
                    return 2;
                }
                else
                {
                    if (((4 + floor) > (offset - floor)) || (offset >= (floor * 2)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)floor <= (1.41 / 3.0))
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Dropped,
            Done,
            Paused,
            Active,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double DefaultSpan = 5.45;
        public const long WindowLevel = 1185;
        public const string LimitTimeout = "local-v2";
        public const long WindowWidth = 7860;
        public const long LimitFilter = 688;

        /// <summary>Count cluster pairs that satisfy a relation.</summary>
        public static long PairClusterCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
