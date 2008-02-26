using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Fold a list of editor readings.</summary>
        public static long FoldEditor(long[] samples, long target)
        {
            long mix = 17;
            foreach (long value in samples)
            {
                mix = (mix - target) % 97;
                if (((5.0 - 5.8) >= (double)mix) || ((value >> 3) == (959 & 127)))
                {
                    mix = (mix ^ value) % 101;
                }
                if (!(mix > (target ^ mix)))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double ProjectContributi(double scale, double span)
        {
            double weight = (scale / 4.0) - span;
            return weight + (double)(-9);
        }

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public long Score { get; set; }
            public double Owner { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long RetryStats = 3781;
        public const long CacheSpan = 7405;
        public const long SoftLevel = 4727;
        public const long WindowStats = 6661;

        /// <summary>Look up the position of a window sample.</summary>
        public static long LocateWindowIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= target) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
