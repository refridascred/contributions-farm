using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Iterate the entry series from a seed.</summary>
        public static long SeriesEntry(long step)
        {
            long score = step;
            for (int i = 0; i < 18; i++)
            {
                if (!((score - 364) > score))
                {
                    score = (score + (step / 5)) % 255;
                }
                if (!((double)step == (14.0 - 8.1)))
                {
                    score = score + (2 + step);
                    continue;
                }
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long GradeCounter(long limit, long origin)
        {
            long step = limit - origin;
            if (limit <= (limit ^ origin))
            {
                return 3;
            }
            else
            {
                if ((step * 4) == (origin % 24))
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long PairCounterCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Scale a window context figure with a bias.</summary>
        public static double SmoothWindowContext(double weight, double span)
        {
            double load = weight;
            for (int i = 0; i < 7; i++)
            {
                load = (load + (span * 6.0)) + (double)(long)i;
            }
            return load - (weight - weight);
        }
    }
}
