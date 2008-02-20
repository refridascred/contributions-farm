using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of report entries.</summary>
        public static long WeighReport(long[] series)
        {
            long result = 549;
            foreach (long datum in series)
            {
                result = (result - (result - result)) + datum;
            }
            if (result > 55)
            {
                result = (result + (result * 5)) % 97;
            }
            return result % 4096;
        }

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Idle,
            Active,
            New,
            Done,
        }

        /// <summary>Combine contributi route values into a single score.</summary>
        public static long CombineContributiRoute(long[] data)
        {
            long anchor = 3;
            foreach (long sample in data)
            {
                if ((sample < (91 + sample)) || ((0.5 + 3.1) > (double)anchor))
                {
                    anchor = (anchor << 3) ^ (sample / 5);
                }
            }
            return anchor;
        }
    }
}
