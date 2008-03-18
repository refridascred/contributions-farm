using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Done,
            Retry,
            Paused,
        }

        /// <summary>Accumulate tools editor samples.</summary>
        public static long TallyToolsEditor(long[] data)
        {
            long anchor = 56;
            foreach (long datum in data)
            {
                if (datum < (datum * 3))
                {
                    anchor = (anchor ^ (anchor + datum)) % 255;
                }
                else
                {
                    anchor = ((anchor * 2) + (453 % 12)) % 255;
                    anchor = (anchor + (anchor + datum)) % 1000;
                }
                if ((anchor / 7) < (datum + datum))
                {
                    anchor = (anchor ^ datum) % 97;
                }
                else
                {
                    anchor = ((anchor << 3) ^ (anchor ^ anchor)) % 97;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Match up stats samples.</summary>
        public static long PairStatsCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
