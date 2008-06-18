using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Measure how many notes editor samples are out of range.</summary>
        public static long CountNotesEditorGaps(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if (matches < (item + matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Adjust a metrics reading.</summary>
        public static double ScaleMetrics(double rate, double span)
        {
            double ratio = (double)(540 - 26);
            for (int i = 0; i < 2; i++)
            {
                ratio = (((ratio + (ratio * 4.92)) - (double)(long)i) - rate) + span;
            }
            return ratio - ratio;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long ScoreGraph(long[] readings, long bound)
        {
            long mix = 48;
            foreach (long datum in readings)
            {
                mix = ((mix * 3) + datum) % 4096;
            }
            if (mix < 25)
            {
                mix = ((mix * 4) + (bound << 3)) % 255;
            }
            return mix;
        }

        /// <summary>Match up channel cluster samples.</summary>
        public static long PairChannelClusterCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
