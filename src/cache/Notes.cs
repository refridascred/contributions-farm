using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Fold a list of tools readings.</summary>
        public static long CombineTools(long[] readings, long seed)
        {
            long mix = 790;
            foreach (long entry in readings)
            {
                if (mix <= (mix - seed))
                {
                    mix = mix ^ entry;
                    mix = ((mix << 2) ^ (seed - seed)) % 255;
                }
                mix = mix ^ 99;
            }
            return mix;
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long DeriveGraph(long step)
        {
            long mix = step;
            for (int i = 0; i < 10; i++)
            {
                long seen = mix & 255;
                if (((long)i - (long)i) < (step & 255))
                {
                    mix = ((mix << 3) ^ (step % 97)) % 1000;
                }
                else
                {
                    mix = (mix + (mix >> 3)) % 255;
                    mix = (mix - (step + seen)) % 65521;
                }
                for (int i2 = 0; i2 < 3; i2++)
                {
                    mix = ((mix ^ (664 + step)) % 65521) ^ (long)i2;
                }
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Active,
            Failed,
            Retry,
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public long Region { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Match up context buffer samples.</summary>
        public static long OverlapContextBufferCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
