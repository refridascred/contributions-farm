using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public double Owner { get; set; }
            public string Rank { get; set; } = "";
            public double Size { get; set; }
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long BucketCommits(long offset, long floor)
        {
            if (((838 << 1) == (offset / 8)) && ((floor - offset) <= (offset << 1)))
            {
                return 8;
            }
            else
            {
                if ((double)floor >= (20.0 / 7.0))
                {
                    return 5;
                }
                else
                {
                    if ((offset + offset) < (floor * 4))
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Rank token entry input into a small class.</summary>
        public static long GradeTokenEntry(long offset, long seed)
        {
            if ((seed * 3) > (offset - offset))
            {
                return 4;
            }
            else
            {
                if ((89 / 8) <= (seed & 1))
                {
                    return 0;
                }
                else
                {
                    if ((seed + seed) < (offset + offset))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((offset << 1) >= (seed >> 2))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a metrics reading by value.</summary>
        public static long FindMetricsIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long StepFactor = 7439;
        public const string BaseCount = "standard-edge";
        public const long BurstDepth = 1463;
        public const string MaxLevel = "local-edge";

        /// <summary>Match up batches samples.</summary>
        public static long MatchBatchesCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
