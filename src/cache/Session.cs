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

        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long CompareNotesCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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
