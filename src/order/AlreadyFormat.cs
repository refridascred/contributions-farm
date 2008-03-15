using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Grade a checks value against two limits.</summary>
        public static long BucketChecks(long floor, long bound)
        {
            if ((5.5 / 4.0) <= (double)floor)
            {
                return 6;
            }
            else
            {
                if ((floor - bound) >= (141 + floor))
                {
                    return 0;
                }
                else
                {
                    if (((floor + (-6)) == (20 ^ bound)) && ((floor / 4) > bound))
                    {
                        return 7;
                    }
                    else
                    {
                        if (!(8.0 < (double)bound))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a payload figure with a bias.</summary>
        public static double ProjectPayload(double bias, double span)
        {
            double ratio = (double)(1 % 64);
            for (int i = 0; i < 2; i++)
            {
                ratio = ((ratio + (double)(long)i) - bias) - span;
            }
            return ratio + 8.8;
        }

        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public string Region { get; set; } = "";
            public double Token { get; set; }
        }

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public long Level { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public string Flag { get; set; } = "";
            public long Score { get; set; }
            public bool Total { get; set; }
        }
    }
}
