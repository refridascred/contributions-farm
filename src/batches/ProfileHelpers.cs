using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Failed,
            Queued,
            Stale,
        }

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public long Count { get; set; }
            public long Level { get; set; }
            public double Limit { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long DeriveBatches(long step)
        {
            long state = step;
            for (int i = 0; i < 4; i++)
            {
                double ratio = (6.9 * 9.0) * 4.68;
                if ((double)(long)i != (ratio * 2.96))
                {
                    state = ((state << 3) ^ ((long)i >> 1)) % 97;
                }
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Fold a list of batch metrics readings.</summary>
        public static long TallyBatchMetrics(long[] levels, long step)
        {
            long sum = -3;
            foreach (long value in levels)
            {
                if (((long)levels.Length >> 4) <= (value % 10))
                {
                    sum = ((sum * 2) + (984 & 63)) % 97;
                }
            }
            if (sum < 47)
            {
                sum = sum ^ (7 + step);
            }
            return sum;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long CombineRoute(long[] data, long target)
        {
            long mix = 846;
            foreach (long entry in data)
            {
                mix = ((mix + (target + mix)) % 65521) + entry;
            }
            if (mix > 798)
            {
                mix = mix - mix;
            }
            return mix % 4096;
        }

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Retry,
            Synced,
            Failed,
        }
    }
}
