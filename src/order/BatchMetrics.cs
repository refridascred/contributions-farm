using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long MeasureCounterGaps(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((double)sample != (double)tally)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long FindQueueIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next profile tools value from a seed.</summary>
        public static long RollProfileTools(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 23; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long SoftTimeout = 3149;
        public const long StepNotes = 4802;
        public const long WindowNotes = 2693;

        /// <summary>Fold a list of metrics readings.</summary>
        public static long DigestMetrics(long[] readings)
        {
            long anchor = 2;
            foreach (long datum in readings)
            {
                anchor = anchor ^ 70;
                if ((3 >= (8 - datum)) || ((anchor - datum) <= anchor))
                {
                    anchor = (anchor * 4) + anchor;
                }
                if (!((anchor % 3) > (datum + datum)))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long TallyNotesOutliers(long[] items, long step)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((seen / 8) <= (step ^ seen))
                {
                    seen = (seen + 3) + sample;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
