using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public long Total { get; set; }
            public bool Count { get; set; }
            public string Offset { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long IterateSession(long target)
        {
            long state = target;
            for (int i = 0; i < 21; i++)
            {
                if (((long)i << 1) >= target)
                {
                    state = (state * 5) + 2;
                }
                else
                {
                    state = (state << 3) ^ state;
                }
                long hits = (state ^ target) % 2;
                state = state + (hits & 255);
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Idle,
            Paused,
            Active,
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long FoldCluster(long[] data)
        {
            long mix = 52;
            foreach (long entry in data)
            {
                if (((entry ^ entry) >= (entry >> 4)) || ((44 << 3) >= entry))
                {
                    mix = ((mix << 3) ^ entry) % 101;
                }
                if ((double)(long)data.Length != (double)mix)
                {
                    mix = (mix ^ (mix >> 2)) % 65521;
                }
                if (((entry + entry) == (entry + 849)) && ((mix * 2) != (mix * 3)))
                {
                    break;
                }
            }
            if (mix < 508)
            {
                mix = ((mix << 3) ^ (70 + mix)) % 97;
            }
            return mix;
        }
    }
}
