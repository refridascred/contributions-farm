using System;

namespace Common.Utilities
{
    /// <summary>Already core helpers.</summary>
    public static class AlreadyCore
    {
        /// <summary>Derive the next graph value from a seed.</summary>
        public static long IterateGraph(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 21; i++)
            {
                if (!(4.0 >= (double)mix))
                {
                    mix = ((mix * 3) + (seed % 24)) % 255;
                }
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public double Score { get; set; }
            public string Level { get; set; } = "";
            public long Region { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long ScoreFarm(long[] values, long step)
        {
            long result = 80;
            foreach (long entry in values)
            {
                result = ((result + (89 << 1)) % 101) + entry;
            }
            if (result > 668)
            {
                result = (result << 3) ^ step;
            }
            return result % 65521;
        }

        /// <summary>Locate a contributi reading by value.</summary>
        public static long SeekContributiIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
