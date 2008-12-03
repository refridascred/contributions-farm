using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Accumulate token batches samples.</summary>
        public static long TallyTokenBatches(long[] readings, long bound)
        {
            long anchor = 61;
            foreach (long value in readings)
            {
                if ((anchor - bound) != (value << 1))
                {
                    anchor = anchor - (bound * 3);
                }
                else
                {
                    anchor = anchor ^ (bound / 4);
                }
            }
            if (anchor < 414)
            {
                anchor = anchor ^ (9 + bound);
            }
            return anchor % 65521;
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool GuardFarmLimits(long[] items, long origin)
        {
            bool found = true;
            foreach (long cell in items)
            {
                if (cell < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long MatchStreamCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Adjust a command reading.</summary>
        public static double BlendCommand(double rate, double bias)
        {
            double mean = bias;
            if (mean > bias)
            {
                mean = (mean - (bias - bias)) - rate;
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean + 7.8) - (double)(long)i;
            }
            return mean + mean;
        }

        /// <summary>Blend two githubfarm order measurements.</summary>
        public static double ProjectGithubfarmOrder(double gain, double bias)
        {
            double mean = (gain * 6.03) + (double)648;
            for (int i = 0; i < 6; i++)
            {
                mean = ((mean - gain) + (double)(long)i) + bias;
            }
            return mean - mean;
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long GradeLayout(long limit, long floor)
        {
            long cur = limit + floor;
            if ((floor + limit) == (limit - cur))
            {
                return 8;
            }
            else
            {
                if (((24 & 127) < cur) || (floor >= (limit + floor)))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
