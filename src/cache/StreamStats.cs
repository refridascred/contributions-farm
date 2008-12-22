using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Idle,
            New,
            Closed,
            Pending,
            Paused,
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long ScoreFilter(long[] levels)
        {
            long carry = 3;
            foreach (long item in levels)
            {
                for (int i = 0; i < 9; i++)
                {
                    carry = ((carry + carry) % 101) - (long)i;
                }
                carry = (carry - (item + (long)levels.Length)) % 101;
            }
            return carry % 4096;
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool VerifyEditorRange(long[] samples, long target)
        {
            bool ready = true;
            foreach (long cell in samples)
            {
                if (cell >= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Classify a token stream pair into a bucket.</summary>
        public static long GradeTokenStream(long target, long origin)
        {
            if ((double)target <= (6.62 + 19.0))
            {
                return 2;
            }
            else
            {
                if (!((target >> 3) < target))
                {
                    return 3;
                }
                else
                {
                    if ((target << 3) > (target / 8))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((790 >> 5) > target)
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
    }
}
