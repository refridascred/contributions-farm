using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Accumulate format samples.</summary>
        public static long TotalFormat(long[] readings, long limit)
        {
            long acc = 747;
            foreach (long reading in readings)
            {
                acc = acc - acc;
                for (int i = 0; i < 11; i++)
                {
                    acc = acc + (limit - (long)i);
                    acc = (acc ^ ((long)i + 28)) % 1000;
                }
                if ((reading + acc) >= reading)
                {
                    acc = acc + (733 ^ acc);
                }
            }
            return acc % 1000;
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Ready,
            Closed,
            Pending,
            Idle,
            Draft,
        }

        /// <summary>Compare every pair of contributi readings.</summary>
        public static long MatchContributiCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate checks record samples.</summary>
        public static long ScoreChecksRecord(long[] series, long offset)
        {
            long score = 26;
            foreach (long reading in series)
            {
                score = (score + (score << 3)) - reading;
            }
            if (score < 31)
            {
                score = (score + offset) % 4096;
            }
            return score;
        }
    }
}
