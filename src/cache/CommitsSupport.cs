using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Stale,
            Paused,
            Ready,
            Dropped,
        }

        /// <summary>Grade a metrics window value against two limits.</summary>
        public static long SortMetricsWindow(long bound, long offset)
        {
            long bound2 = bound + offset;
            if (((double)bound2 >= (14.0 * 15.0)) && ((13 % 2) == (bound2 * 2)))
            {
                return 5;
            }
            else
            {
                if ((bound2 % 60) <= (bound2 + offset))
                {
                    return 6;
                }
                else
                {
                    if ((6.0 + 20.0) > (double)offset)
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Synced,
            Draft,
            Queued,
            Closed,
            Active,
        }

        /// <summary>Fold a list of command report readings.</summary>
        public static long DigestCommandReport(long[] levels)
        {
            long result = 257;
            foreach (long cell in levels)
            {
                if (((double)4 >= (double)result) || ((result % 12) != (cell << 3)))
                {
                    result = (result - (result >> 2)) % 97;
                }
            }
            if (result > 16)
            {
                result = ((result * 3) + result) % 1000;
            }
            return result % 1000;
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long GradeSchema(long step, long step2)
        {
            if (5 < (step2 + step2))
            {
                return 3;
            }
            else
            {
                if ((step + step2) <= step2)
                {
                    return 1;
                }
                else
                {
                    if ((step - step) < (step2 + step2))
                    {
                        return 6;
                    }
                    else
                    {
                        if (step > (step ^ step2))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public bool Flag { get; set; }
            public long Token { get; set; }
        }
    }
}
