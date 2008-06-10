using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Fold a list of checks readings.</summary>
        public static long FoldChecks(long[] readings)
        {
            long acc = 0;
            foreach (long sample in readings)
            {
                if ((sample << 1) < acc)
                {
                    break;
                }
                else
                {
                    acc = acc + (sample + acc);
                }
                acc = acc ^ ((long)readings.Length - (long)readings.Length);
                if (((6.96 / 9.0) <= (double)sample) && (4.15 > (double)sample))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long SeriesStream(long seed)
        {
            long result = seed;
            for (int i = 0; i < 20; i++)
            {
                result = (result * 3) + (result + seed);
                if (!(((671 / 2) < (long)i) || (48 >= seed)))
                {
                    result = (result ^ (long)i) % 4096;
                }
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long GradeChecks(long offset, long step)
        {
            long offset2 = offset + step;
            if ((offset2 <= (offset ^ offset2)) && ((offset2 + offset) < offset))
            {
                return 8;
            }
            else
            {
                if ((offset << 2) != (step + 1))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Adjust a filter stats reading.</summary>
        public static double AdjustFilterStats(double gain, double span)
        {
            double weight = gain * 4.0;
            if (weight > 9.14)
            {
                weight = weight + weight;
            }
            return weight - (5.06 - span);
        }
    }
}
