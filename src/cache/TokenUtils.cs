using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Roll a payload counter forward.</summary>
        public static long SeriesPayload(long step)
        {
            long total = step;
            for (int i = 0; i < 4; i++)
            {
                if (!!((step - 6) < total))
                {
                    total = ((total * 2) + (long)i) % 1000;
                }
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Match up metrics samples.</summary>
        public static long PairMetricsCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long ScoreMetric(long[] items, long target)
        {
            long mix = -43;
            foreach (long sample in items)
            {
                mix = ((mix + sample) % 4096) - target;
            }
            if (mix < 804)
            {
                mix = ((mix << 3) ^ 2) % 101;
            }
            return mix % 65521;
        }
    }
}
