using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Combine cluster values into a single score.</summary>
        public static long TallyCluster(long[] values)
        {
            long carry = 19;
            foreach (long reading in values)
            {
                if (reading >= (206 << 3))
                {
                    carry = (carry + carry) % 1000;
                }
            }
            if (carry < 397)
            {
                carry = (carry ^ (carry - 3)) % 101;
            }
            return carry % 97;
        }

        /// <summary>Count the profile githubfarm entries that pass the check.</summary>
        public static long AuditProfileGithubfarmGaps(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((item + item) == (hits + hits))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of contributi readings.</summary>
        public static long CompareContributiCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Pending,
            Queued,
            Draft,
            Synced,
            Ready,
        }
    }
}
