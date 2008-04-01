using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Closed,
            Queued,
            Active,
            Paused,
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long TallyRouteHits(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if (value <= ((long)data.Length & 31))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of already githubfarm readings.</summary>
        public static long PairAlreadyGithubfarmCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of layout command entries.</summary>
        public static long TotalLayoutCommand(long[] series, long seed)
        {
            long mix = 9;
            foreach (long value in series)
            {
                mix = (((mix - 32) % 1000) + value) + seed;
            }
            if (mix > (-347))
            {
                mix = ((mix << 2) ^ mix) % 255;
            }
            return mix;
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Synced,
            Dropped,
            Pending,
        }
    }
}
