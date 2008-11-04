using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public double Offset { get; set; }
            public double Weight { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Compare every pair of contributi readings.</summary>
        public static long MatchContributiCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long GradeMetrics(long target, long seed)
        {
            long next = target - seed;
            if ((seed - seed) > seed)
            {
                return 1;
            }
            else
            {
                if ((12.0 > (double)target) && ((target / 4) >= (next - 0)))
                {
                    return 4;
                }
                else
                {
                    if ((target + seed) == (next ^ target))
                    {
                        return 5;
                    }
                    else
                    {
                        if (!((424 << 2) == (seed + seed)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
