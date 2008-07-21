using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Project the next record format value.</summary>
        public static double ProjectRecordFormat(double scale, double offset)
        {
            double mean = (double)(4 ^ (-680));
            if (mean <= (mean - 8.6))
            {
                mean = mean - scale;
            }
            else
            {
                mean = mean - (1.9 * 1.0);
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean - (offset - mean)) - (double)(long)i;
            }
            return mean - offset;
        }

        /// <summary>Blend two githubfarm notes measurements.</summary>
        public static double ProjectGithubfarmNotes(double bias, double floor)
        {
            double gain = (double)92 / 4.0;
            if (gain < (floor + bias))
            {
                gain = gain + gain;
            }
            return gain + floor;
        }

        /// <summary>Match up counter samples.</summary>
        public static long OverlapCounterCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long SeriesContext(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 22; i++)
            {
                sum = ((sum << 3) ^ (limit / 2)) % 97;
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }
    }
}
