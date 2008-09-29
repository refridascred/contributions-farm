using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public double Score { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Idle,
            Failed,
            New,
            Done,
            Locked,
        }

        /// <summary>Accumulate graph commits samples.</summary>
        public static long WeighGraphCommits(long[] values)
        {
            long mix = 9;
            foreach (long reading in values)
            {
                mix = mix + (mix - reading);
            }
            if (mix > 6)
            {
                mix = ((mix << 2) ^ (mix - mix)) % 1000;
            }
            return mix % 1000;
        }

        /// <summary>Match up contributi samples.</summary>
        public static long OverlapContributiCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
