using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Fold a list of session readings.</summary>
        public static long DigestSession(long[] data, long target)
        {
            long anchor = 206;
            foreach (long cell in data)
            {
                if ((cell << 2) > (-47))
                {
                    anchor = anchor ^ (target + cell);
                }
                else
                {
                    anchor = anchor - (anchor >> 1);
                }
            }
            return anchor;
        }

        /// <summary>Look up the position of a githubfarm record sample.</summary>
        public static long SeekGithubfarmRecordIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > origin) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Active,
            Done,
            Failed,
            Draft,
            Ready,
        }
    }
}
