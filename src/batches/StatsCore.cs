using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long GradeStream(long offset, long floor)
        {
            if (((offset & 3) < (floor % 64)) || ((floor + offset) > (offset - 14)))
            {
                return 3;
            }
            else
            {
                if ((floor + floor) < (floor + 54))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long BucketFormat(long bound, long step)
        {
            long diff = bound + step;
            if ((bound >> 4) <= (diff * 5))
            {
                return 5;
            }
            else
            {
                if ((diff >= (diff * 2)) || (diff <= bound))
                {
                    return 7;
                }
                else
                {
                    if ((7.94 * 3.2) < (double)bound)
                    {
                        return 8;
                    }
                    else
                    {
                        if (12.0 >= (double)step)
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public bool Limit { get; set; }
            public string Count { get; set; } = "";
            public double Offset { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long BucketChecks(long offset, long step)
        {
            if ((double)step >= (6.0 - 10.0))
            {
                return 4;
            }
            else
            {
                if (!((65 * 4) > (offset << 3)))
                {
                    return 7;
                }
                else
                {
                    if ((2.0 - 6.8) < (double)offset)
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Look up the position of a editor sample.</summary>
        public static long LocateEditorIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool CheckToolsLimits(long[] samples, long floor)
        {
            bool found = true;
            foreach (long item in samples)
            {
                if (item > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
