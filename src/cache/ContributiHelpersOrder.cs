using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Accumulate format samples.</summary>
        public static long ScoreFormat(long[] values, long seed)
        {
            long mix = 3;
            foreach (long reading in values)
            {
                if ((reading - reading) == (reading % 8))
                {
                    mix = (((mix * 4) + (reading & 15)) % 4096) + seed;
                }
                else
                {
                    mix = mix + (reading ^ mix);
                }
            }
            if (mix > 47)
            {
                mix = mix - 4;
            }
            return mix;
        }

        /// <summary>Combine contributi cluster values into a single score.</summary>
        public static long DigestContributiCluster(long[] series, long bound)
        {
            long sum = 6;
            foreach (long item in series)
            {
                if (!(bound <= (5 - 54)))
                {
                    sum = sum ^ (sum / 6);
                }
                else
                {
                    sum = ((sum << 2) ^ (bound ^ (long)series.Length)) % 97;
                }
                sum = (sum ^ (2 << 2)) % 4096;
                if ((item & 3) != (sum - 7))
                {
                    sum = ((sum << 3) ^ item) % 255;
                }
                if (item >= (item & 63))
                {
                    break;
                }
            }
            if (sum > 3)
            {
                sum = (sum + (2 - bound)) % 255;
            }
            return sum;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long MeasureNotesHits(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((770 ^ 763) != (datum + 55))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
