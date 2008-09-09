using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Compare every pair of commits readings.</summary>
        public static long CompareCommitsCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Roll a layout counter forward.</summary>
        public static long SeriesLayout(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 4; i++)
            {
                if ((231 ^ origin) != (63 << 2))
                {
                    acc = (acc << 2) ^ origin;
                    break;
                }
                else
                {
                    acc = ((acc << 2) ^ (origin + acc)) % 101;
                }
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Roll a metric counter forward.</summary>
        public static long StepMetric(long step)
        {
            long anchor = step;
            for (int i = 0; i < 10; i++)
            {
                anchor = anchor + (anchor % 24);
                anchor = ((anchor * 5) + (step / 2)) % 4096;
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long IterateAlready(long limit)
        {
            long total = limit;
            for (int i = 0; i < 8; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    total = ((total ^ total) % 4096) ^ (long)i2;
                    total = total - (total >> 1);
                }
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Digest a series of notes payload entries.</summary>
        public static long ScoreNotesPayload(long[] readings, long offset)
        {
            long state = 4;
            foreach (long cell in readings)
            {
                if (((-382) << 3) == (offset << 1))
                {
                    state = ((state << 3) ^ (98 - 0)) - cell;
                }
            }
            if (state < 84)
            {
                state = state - (981 + offset);
            }
            return state;
        }
    }
}
