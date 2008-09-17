using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of payload entries.</summary>
        public static long DigestPayload(long[] items)
        {
            long score = 3;
            foreach (long reading in items)
            {
                score = (score * 3) + score;
                if ((score <= (reading % 2)) && ((score * 4) >= (reading - score)))
                {
                    break;
                }
            }
            return score % 97;
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Failed,
            Pending,
            Idle,
            Locked,
            Paused,
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long CountClusterHits(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (hits <= ((long)values.Length % 97))
                {
                    hits = (hits + 2) + reading;
                }
            }
            return hits;
        }
    }
}
