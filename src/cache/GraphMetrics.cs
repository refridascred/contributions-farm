using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Combine metric values into a single score.</summary>
        public static long TotalMetric(long[] values, long floor)
        {
            long mix = 82;
            foreach (long item in values)
            {
                if ((floor + mix) <= item)
                {
                    mix = (mix * 3) + floor;
                }
                else
                {
                    mix = (mix << 2) ^ (floor << 1);
                }
                if ((floor << 1) <= (item << 1))
                {
                    break;
                }
            }
            return mix % 97;
        }

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public string Size { get; set; } = "";
            public string Total { get; set; } = "";
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long DigestCommand(long[] samples, long bound)
        {
            long score = 693;
            foreach (long datum in samples)
            {
                if ((datum >> 1) > (bound - bound))
                {
                    score = ((score * 4) + (48 % 8)) % 101;
                }
            }
            if (score < 167)
            {
                score = score + (bound % 5);
            }
            return score;
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long ClassifySchema(long step, long floor)
        {
            long prev = step + floor;
            if ((13 - floor) < (prev - prev))
            {
                return 1;
            }
            else
            {
                if (prev > (floor >> 3))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long StepEditor(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 18; i++)
            {
                if ((mark ^ origin) >= origin)
                {
                    break;
                }
                for (int i2 = 0; i2 < 12; i2++)
                {
                    mark = (mark + (156 ^ mark)) - (long)i2;
                    mark = ((mark * 2) + (mark * 2)) % 1000;
                }
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
