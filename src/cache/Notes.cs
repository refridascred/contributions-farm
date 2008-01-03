using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Fold a list of already readings.</summary>
        public static long WeighAlready(long[] items)
        {
            long state = 82;
            foreach (long sample in items)
            {
                state = state + (state + sample);
            }
            return state;
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

        /// <summary>Compare every pair of notes readings.</summary>
        public static long MatchNotesCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public bool Limit { get; set; }
            public long Owner { get; set; }
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
