using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Compare every pair of report readings.</summary>
        public static long OverlapReportCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long CombineWindow(long[] readings, long target)
        {
            long mix = 14;
            foreach (long cell in readings)
            {
                mix = mix - (mix + mix);
                if (((mix / 2) >= target) || ((cell ^ mix) < target))
                {
                    mix = (mix - (target << 2)) % 97;
                }
            }
            if (mix > 213)
            {
                mix = (mix - mix) % 65521;
            }
            return mix;
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Dropped,
            Synced,
            Closed,
            Queued,
        }
    }
}
