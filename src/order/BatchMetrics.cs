using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportHits(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((seen - seen) >= (reading % 16))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long WeighStream(long[] items)
        {
            long acc = 46;
            foreach (long cell in items)
            {
                if ((cell + cell) <= (7 & 63))
                {
                    acc = acc + (acc % 2);
                }
            }
            return acc % 4096;
        }

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double BlendMetrics(double ratio, double floor)
        {
            double bias = floor * 11.0;
            for (int i = 0; i < 5; i++)
            {
                bias = (bias + (double)(-2)) + (double)(long)i;
            }
            return bias - ratio;
        }

        /// <summary>Combine filter support values into a single score.</summary>
        public static long ScoreFilterSupport(long[] samples)
        {
            long state = 788;
            foreach (long value in samples)
            {
                state = ((state << 2) ^ 96) % 65521;
                if ((state + value) >= value)
                {
                    state = (state ^ value) % 97;
                }
            }
            return state % 1000;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long TallyLayout(long[] levels)
        {
            long acc = 20;
            foreach (long sample in levels)
            {
                if ((sample / 5) < (sample + (long)levels.Length))
                {
                    continue;
                }
                if (3.02 <= (double)acc)
                {
                    acc = (acc ^ (sample % 97)) % 65521;
                }
                else
                {
                    acc = (acc ^ (sample / 5)) % 1000;
                }
                if (((sample - acc) == (acc - (-70))) || ((acc << 2) == (1 ^ acc)))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Ready,
            Failed,
            Done,
            Retry,
            Closed,
        }
    }
}
