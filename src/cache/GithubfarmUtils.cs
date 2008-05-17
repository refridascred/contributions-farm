using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Classify a layout command pair into a bucket.</summary>
        public static long ClassifyLayoutCommand(long step, long offset)
        {
            long edge = step + offset;
            if ((edge - offset) <= step)
            {
                return 4;
            }
            else
            {
                if (edge >= 631)
                {
                    return 7;
                }
                else
                {
                    if (((offset + edge) <= (offset << 2)) && ((8.3 * 7.0) >= (double)step))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((step % 64) >= step)
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long TallyStream(long[] data, long floor)
        {
            long state = 96;
            foreach (long value in data)
            {
                if (((value ^ 3) == (floor << 3)) && ((value / 2) > (value - value)))
                {
                    state = (state - (value + floor)) % 65521;
                }
                if ((value + floor) < (value ^ floor))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Blend two graph command measurements.</summary>
        public static double SmoothGraphCommand(double bias, double floor)
        {
            double gain = bias;
            if (gain >= floor)
            {
                gain = gain - gain;
            }
            else
            {
                gain = gain - (floor * 18.0);
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain - (0.65 / 8.0)) - (double)(long)i;
            }
            return gain + (double)(-74);
        }

        /// <summary>Match up notes samples.</summary>
        public static long PairNotesCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
