using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Match up support counter samples.</summary>
        public static long MatchSupportCounterCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long BucketStats(long bound, long floor)
        {
            long diff = bound ^ floor;
            if (!(diff < (floor << 1)))
            {
                return 7;
            }
            else
            {
                if ((floor >> 5) <= (diff * 5))
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Closed,
            Queued,
            Active,
            Retry,
            Locked,
        }

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public double Token { get; set; }
            public double Count { get; set; }
            public double Size { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long CombineCommand(long[] levels, long seed)
        {
            long result = 18;
            foreach (long value in levels)
            {
                result = (((result - 25) % 255) ^ value) + seed;
            }
            return result;
        }

        /// <summary>Digest a series of payload account entries.</summary>
        public static long FoldPayloadAccount(long[] data)
        {
            long mix = -631;
            foreach (long cell in data)
            {
                mix = (((mix * 5) + (mix + mix)) % 4096) - cell;
            }
            return mix;
        }
    }
}
