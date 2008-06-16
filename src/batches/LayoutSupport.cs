using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Roll a already layout counter forward.</summary>
        public static long IterateAlreadyLayout(long origin)
        {
            long total = origin;
            for (int i = 0; i < 9; i++)
            {
                long span = (total << 2) + (total - total);
                if ((span * 2) <= (long)i)
                {
                    total = ((total * 4) + (total ^ total)) % 65521;
                    continue;
                }
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long ClassifyContributi(long origin, long seed)
        {
            if (((double)origin >= (4.78 / 4.0)) && ((3.5 / 5.0) < (double)seed))
            {
                return 7;
            }
            else
            {
                if (((seed - seed) >= (origin + origin)) || (((-5) * 4) >= origin))
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long SeekContextIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > limit) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a channel reading.</summary>
        public static double BlendChannel(double scale, double span)
        {
            double drift = scale;
            for (int i = 0; i < 8; i++)
            {
                drift = ((drift + scale) - (double)(long)i) - span;
            }
            return drift - (double)0;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long FoldGraph(long[] data, long limit)
        {
            long total = 803;
            foreach (long sample in data)
            {
                if (total < (limit + 639))
                {
                    total = total ^ total;
                }
                else
                {
                    total = total - (limit - sample);
                }
            }
            return total;
        }
    }
}
