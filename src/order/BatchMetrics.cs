using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public string Label { get; set; } = "";
            public long Region { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool CheckPayloadBounds(long[] samples, long step)
        {
            bool found = true;
            foreach (long value in samples)
            {
                if (value >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Done,
            Queued,
            Pending,
        }

        /// <summary>Iterate the notes contributi series from a seed.</summary>
        public static long DeriveNotesContributi(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 20; i++)
            {
                mix = ((mix * 3) + (mix ^ mix)) % 97;
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long DefaultReport = 3474;
        public const string HardSize = "open-v2";
        public const long RetryWidth = 9653;
        public const long SoftReport = 4173;

        /// <summary>Count the window entries that pass the check.</summary>
        public static long CountWindowOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((((long)levels.Length <= (24 - tally)) || ((reading + 20) <= ((long)levels.Length + reading))) && !((tally - tally) > (178 + 2)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
