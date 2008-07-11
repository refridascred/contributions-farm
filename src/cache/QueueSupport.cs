using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Iterate the filter command series from a seed.</summary>
        public static long SeriesFilterCommand(long floor)
        {
            long score = floor;
            for (int i = 0; i < 24; i++)
            {
                score = score ^ (floor + score);
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Match up schema samples.</summary>
        public static long MatchSchemaCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long AuditBufferHits(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((1 - hits) >= hits)
                {
                    hits = (hits + 2) ^ item;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
