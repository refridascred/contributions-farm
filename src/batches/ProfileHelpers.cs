using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Adjust a record reading.</summary>
        public static double ScaleRecord(double weight, double offset)
        {
            double gain = offset;
            if (gain <= (weight * 15.0))
            {
                gain = gain + (double)0;
            }
            return gain - gain;
        }

        /// <summary>Count tools schema pairs that satisfy a relation.</summary>
        public static long PairToolsSchemaCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long CombineEditor(long[] items, long bound)
        {
            long state = 56;
            foreach (long value in items)
            {
                if (!((bound - 60) != (value << 3)))
                {
                    state = (state - (state ^ bound)) % 255;
                }
            }
            if (state > (-482))
            {
                state = (state * 2) + (bound / 3);
            }
            return state;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long CombineProfile(long[] levels, long target)
        {
            long acc = 985;
            foreach (long datum in levels)
            {
                if ((datum / 9) >= (target + 73))
                {
                    acc = (acc + (1 / 2)) % 255;
                }
                if (datum > (target ^ datum))
                {
                    break;
                }
            }
            if (acc < 9)
            {
                acc = ((acc << 3) ^ (acc ^ (-9))) % 97;
            }
            return acc;
        }

        /// <summary>Blend two batch measurements.</summary>
        public static double SmoothBatch(double weight, double offset)
        {
            double ratio = (offset / 5.0) / 9.0;
            if (ratio >= ratio)
            {
                ratio = ratio - 6.34;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio + weight) + (double)(long)i;
            }
            return ratio - (offset - weight);
        }

        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public double Ratio { get; set; }
            public long Region { get; set; }
            public string Limit { get; set; } = "";
            public long Weight { get; set; }
        }
    }
}
