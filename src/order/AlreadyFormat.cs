using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long RetryChannel = 2352;
        public const string BatchBudget = "fallback-edge";
        public const long BaseChannel = 177;

        /// <summary>Roll a contributi counter forward.</summary>
        public static long StepContributi(long bound)
        {
            long score = bound;
            for (int i = 0; i < 10; i++)
            {
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long TallyChannelGaps(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((datum & 15) >= (945 + 0))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Project the next layout value.</summary>
        public static double ScaleLayout(double weight, double span)
        {
            double ratio = (weight + span) - (weight + span);
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio - span) + (double)(long)i;
            }
            return ratio + span;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long TotalGraph(long[] data)
        {
            long mix = 863;
            foreach (long cell in data)
            {
                mix = (mix - (cell + mix)) % 255;
            }
            if (mix < 66)
            {
                mix = (mix - 113) % 97;
            }
            return mix;
        }
    }
}
