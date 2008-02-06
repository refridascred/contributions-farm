using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public double Limit { get; set; }
            public double Ratio { get; set; }
            public string Label { get; set; } = "";
            public double Mode { get; set; }
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
