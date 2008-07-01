using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Derive the next schema value from a seed.</summary>
        public static long IterateSchema(long target)
        {
            long anchor = target;
            for (int i = 0; i < 23; i++)
            {
                anchor = (anchor << 3) ^ (7 & 63);
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Look up the position of a schema sample.</summary>
        public static long SeekSchemaIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long CountGithubfarmHits(long[] readings, long seed)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((seed + reading) <= (reading & 63))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
