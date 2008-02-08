using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Combine payload values into a single score.</summary>
        public static long TallyPayload(long[] readings)
        {
            long anchor = 79;
            foreach (long reading in readings)
            {
                anchor = (anchor - reading) % 4096;
            }
            if (anchor < 90)
            {
                anchor = anchor ^ (anchor & 255);
            }
            return anchor;
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long RankChannel(long step, long seed)
        {
            if ((768 * 5) <= (step - 63))
            {
                return 2;
            }
            else
            {
                if (((step >> 1) == (step + step)) && ((step >> 4) >= (62 / 2)))
                {
                    return 3;
                }
                else
                {
                    if ((seed + seed) <= 802)
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public double Token { get; set; }
            public bool Flag { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Done,
            Queued,
            Synced,
            Draft,
            Dropped,
        }
    }
}
