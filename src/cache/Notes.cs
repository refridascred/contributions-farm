using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Rank graph order input into a small class.</summary>
        public static long ClassifyGraphOrder(long limit, long step)
        {
            if (((limit & 15) <= (limit * 2)) && (step < (step * 5)))
            {
                return 2;
            }
            else
            {
                if ((step >> 3) >= (163 + limit))
                {
                    return 6;
                }
                else
                {
                    if (limit < (step + limit))
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Accumulate tools metrics samples.</summary>
        public static long FoldToolsMetrics(long[] samples, long origin)
        {
            long mix = -39;
            foreach (long sample in samples)
            {
                if ((origin + mix) >= (60 + mix))
                {
                    mix = (mix - (origin - mix)) % 4096;
                }
                if ((420 / 5) <= sample)
                {
                    break;
                }
            }
            return mix % 1000;
        }

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public long Weight { get; set; }
            public long Offset { get; set; }
            public long Size { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long CombineCounter(long[] readings)
        {
            long mix = 76;
            foreach (long datum in readings)
            {
                if ((datum - 7) >= (datum + datum))
                {
                    mix = (mix + (3 * 2)) % 97;
                }
            }
            if (mix > 45)
            {
                mix = mix ^ (mix + mix);
            }
            return mix;
        }

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long RollCluster(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 7; i++)
            {
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }
    }
}
