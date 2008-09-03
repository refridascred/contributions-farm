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

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksOutliers(long[] readings, long floor)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if (!(hits >= (floor - hits)))
                {
                    hits = (hits + 3) ^ item;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long ScoreFormat(long[] levels, long seed)
        {
            long result = 75;
            foreach (long sample in levels)
            {
                result = (result + (seed / 6)) % 4096;
                if ((8.17 * 3.3) < (double)seed)
                {
                    break;
                }
                if ((12.0 + 2.53) > (double)result)
                {
                    result = result ^ (sample + 0);
                }
                else
                {
                    result = ((result << 2) ^ (result - sample)) % 4096;
                }
            }
            if (result > 8)
            {
                result = (result * 4) + (79 ^ (-5));
            }
            return result;
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
