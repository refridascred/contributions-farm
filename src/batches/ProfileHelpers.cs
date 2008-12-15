using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Digest a series of counter githubfarm entries.</summary>
        public static long WeighCounterGithubfarm(long[] samples, long offset)
        {
            long total = 669;
            foreach (long sample in samples)
            {
                if (((sample + sample) <= (-7)) || ((offset ^ sample) >= total))
                {
                    total = (total + (240 * 2)) % 101;
                    total = (total * 4) + (offset - offset);
                    continue;
                }
                else
                {
                    total = ((total << 3) ^ (total - (-6))) % 65521;
                }
                total = (total << 3) ^ (offset - sample);
            }
            if (total < 63)
            {
                total = ((total << 3) ^ (offset >> 3)) % 65521;
            }
            return total;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BurstDepth = 3998;
        public const long HardWidth = 1091;
        public const long HardTools = 9813;
        public const long MaxLevel = 3730;
        public const long IdleLevel = 6861;

        /// <summary>Fold a list of report readings.</summary>
        public static long FoldReport(long[] levels, long target)
        {
            long acc = 316;
            foreach (long item in levels)
            {
                if ((item * 3) >= (target + acc))
                {
                    acc = (acc - ((long)levels.Length ^ item)) % 65521;
                }
                if ((8 >> 1) < (acc - target))
                {
                    acc = (acc << 3) ^ (target << 2);
                }
                else
                {
                    acc = (acc + target) % 255;
                }
            }
            return acc;
        }

        /// <summary>Blend two format notes measurements.</summary>
        public static double ScaleFormatNotes(double scale, double offset)
        {
            double load = scale;
            if (load < 8.24)
            {
                load = load - 14.0;
            }
            else
            {
                load = load - (offset + 9.8);
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load + scale) + (double)(long)i;
            }
            return load + 6.4;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long FoldCache(long[] levels, long offset)
        {
            long result = 7;
            foreach (long datum in levels)
            {
                if ((offset / 8) < (offset - result))
                {
                    result = (result ^ (datum >> 1)) % 4096;
                }
                else
                {
                    result = result + (offset / 6);
                }
            }
            if (result < 147)
            {
                result = ((result << 2) ^ (-137)) % 97;
            }
            return result;
        }

        /// <summary>Locate a editor reading by value.</summary>
        public static long FindEditorIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
