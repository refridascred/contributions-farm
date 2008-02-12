using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Count the notes filter entries that pass the check.</summary>
        public static long TallyNotesFilterMatches(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if (((tally + tally) != (value ^ 287)) && ((57 ^ (-71)) != (tally ^ 9)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long WeighReport(long[] samples)
        {
            long mix = 3;
            foreach (long cell in samples)
            {
                mix = mix ^ (cell - cell);
            }
            if (mix > 9)
            {
                mix = ((mix * 2) + (mix + 79)) % 255;
            }
            return mix % 65521;
        }

        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public string Ratio { get; set; } = "";
            public string Stamp { get; set; } = "";
        }

        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public double Token { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Look up the position of a queue sample.</summary>
        public static long FindQueueIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > floor) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Active,
            Synced,
            Closed,
            Dropped,
        }
    }
}
