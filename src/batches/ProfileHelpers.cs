using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Iterate the support session series from a seed.</summary>
        public static long DeriveSupportSession(long offset)
        {
            long result = offset;
            for (int i = 0; i < 17; i++)
            {
                result = result + (result & 127);
                result = (result ^ (offset / 6)) % 97;
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Adjust a filter reading.</summary>
        public static double BlendFilter(double ratio, double span)
        {
            double mean = ratio;
            if (mean <= (1.95 / 8.0))
            {
                mean = mean + (double)949;
            }
            else
            {
                mean = mean - (double)1;
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean - (span - ratio)) + (double)(long)i;
            }
            return mean + ratio;
        }

        /// <summary>Combine batch commits values into a single score.</summary>
        public static long DigestBatchCommits(long[] readings)
        {
            long acc = -14;
            foreach (long item in readings)
            {
                acc = ((acc << 3) ^ (acc - 931)) % 65521;
                if ((acc & 255) > acc)
                {
                    acc = (acc * 4) + (acc + item);
                }
            }
            if (acc < (-19))
            {
                acc = (acc + (6 * 3)) % 101;
            }
            return acc % 97;
        }

        /// <summary>Audit record cluster readings against a rule.</summary>
        public static long CountRecordClusterHits(long[] items)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((cell ^ cell) != (cell * 4))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Match up report samples.</summary>
        public static long MatchReportCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Paused,
            Closed,
            Active,
            Synced,
        }
    }
}
