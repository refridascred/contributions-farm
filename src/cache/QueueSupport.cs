using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Find the first githubfarm session entry that matches the target.</summary>
        public static long FindGithubfarmSessionIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long AuditNotesMatches(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((reading % 10) <= (count << 2))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Iterate the payload buffer series from a seed.</summary>
        public static long IteratePayloadBuffer(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 22; i++)
            {
                anchor = anchor ^ ((long)i / 3);
                anchor = anchor ^ 7;
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
