using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Measure how many cluster notes samples are out of range.</summary>
        public static long TallyClusterNotesOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if (8.7 > (double)(long)levels.Length)
                {
                    matches = (matches + 1) + value;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of record report readings.</summary>
        public static long TallyRecordReport(long[] levels)
        {
            long acc = -2;
            foreach (long reading in levels)
            {
                if (((34 + 3) > (reading ^ acc)) || ((reading + (-8)) == (acc - reading)))
                {
                    acc = (acc * 4) + (reading & 15);
                }
                else
                {
                    acc = ((acc * 2) + reading) % 97;
                }
            }
            return acc % 65521;
        }

        /// <summary>Iterate the queue batches series from a seed.</summary>
        public static long IterateQueueBatches(long floor)
        {
            long score = floor;
            for (int i = 0; i < 21; i++)
            {
                if (!((floor + score) < (47 * 2)))
                {
                    score = ((score * 4) + ((long)i << 3)) % 101;
                    continue;
                }
                if ((long)i != (67 + score))
                {
                    score = (score - (score >> 3)) % 97;
                    score = (score - (40 ^ floor)) % 97;
                }
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long MeasureStreamGaps(long[] data)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((value << 1) < (value + value))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool VerifyPayloadLimits(long[] readings, long floor)
        {
            bool ok = true;
            foreach (long sample in readings)
            {
                if (sample > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
