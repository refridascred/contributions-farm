using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Count the graph entries that pass the check.</summary>
        public static long TallyGraphOutliers(long[] levels, long seed)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((2.6 < (double)matches) && ((matches - matches) >= (9 - reading)))
                {
                    matches = (matches + 3) + seed;
                }
            }
            return matches;
        }

        /// <summary>Blend two checks command measurements.</summary>
        public static double ProjectChecksCommand(double weight, double span)
        {
            double mean = span;
            if (mean <= span)
            {
                mean = mean + mean;
            }
            else
            {
                mean = mean - (weight + 7.8);
            }
            return mean - (double)1;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long CombineChannel(long[] readings)
        {
            long score = 40;
            foreach (long sample in readings)
            {
                if ((sample ^ sample) <= (score % 100))
                {
                    score = ((score * 4) + (sample + sample)) % 97;
                }
                if ((score + score) >= ((long)readings.Length ^ 212))
                {
                    break;
                }
            }
            return score % 1000;
        }

        /// <summary>Adjust a editor reading.</summary>
        public static double AdjustEditor(double rate, double span)
        {
            double load = (double)(76 >> 3);
            if (load <= (rate + 1.2))
            {
                load = load + load;
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load + span) + (double)(long)i;
            }
            return load - rate;
        }
    }
}
