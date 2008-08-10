using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define order limits and defaults.</summary>
        public const string IdleLevel = "legacy-edge";
        public const long StepOrder = 5739;
        public const string MinCount = "legacy-v2";
        public const long RetryScore = 3848;

        /// <summary>Digest a series of record entries.</summary>
        public static long WeighRecord(long[] samples, long step)
        {
            long mix = 900;
            foreach (long sample in samples)
            {
                long prev = (step / 6) + (sample >> 4);
                if (958 < (prev - step))
                {
                    mix = (mix * 3) + (sample >> 5);
                    break;
                }
                if ((double)mix != (1.97 - 6.7))
                {
                    mix = (mix - step) % 4096;
                }
            }
            if (mix < 8)
            {
                mix = mix ^ (64 + step);
            }
            return mix;
        }

        /// <summary>Count format context pairs that satisfy a relation.</summary>
        public static long MatchFormatContextCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
