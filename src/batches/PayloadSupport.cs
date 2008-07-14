using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Audit already profile readings against a rule.</summary>
        public static long CountAlreadyProfileHits(long[] data, long bound)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((bound - bound) == (946 - count))
                {
                    count = (count + 3) ^ item;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long LocateGithubfarmIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Queued,
            Active,
            New,
            Retry,
        }
    }
}
