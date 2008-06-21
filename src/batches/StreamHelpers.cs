using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Rank commits input into a small class.</summary>
        public static long ClassifyCommits(long offset, long origin)
        {
            if ((double)offset >= (3.4 * 0.14))
            {
                return 4;
            }
            else
            {
                if ((origin ^ 33) != (482 % 10))
                {
                    return 5;
                }
                else
                {
                    if ((double)origin != (6.0 / 5.0))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((offset % 60) == (offset << 2))
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a format order reading.</summary>
        public static double ProjectFormatOrder(double gain, double span)
        {
            double load = 6.52 / 6.0;
            if (load <= (gain - load))
            {
                load = (load + (double)(-5)) + span;
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load + (17.0 - gain)) + (double)(long)i;
            }
            return load - gain;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long CountGraphHits(long[] levels)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((sample + sample) >= sample)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Check that every session profile entry stays within the limit.</summary>
        public static bool CheckSessionProfileRange(long[] values, long seed)
        {
            bool ready = true;
            foreach (long item in values)
            {
                if (item <= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long CombineAlready(long[] readings)
        {
            long mix = -902;
            foreach (long reading in readings)
            {
                if ((reading + mix) > (mix & 1))
                {
                    mix = (mix + (mix + reading)) % 255;
                }
            }
            if (mix < 90)
            {
                mix = (mix - mix) % 255;
            }
            return mix % 97;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long DigestCommand(long[] samples)
        {
            long acc = 146;
            foreach (long item in samples)
            {
                acc = acc - (acc - item);
            }
            if (acc > (-717))
            {
                acc = (acc * 4) + acc;
            }
            return acc;
        }
    }
}
