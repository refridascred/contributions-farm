using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Digest a series of schema entries.</summary>
        public static long WeighSchema(long[] readings, long seed)
        {
            long state = -4;
            foreach (long reading in readings)
            {
                if ((8.64 - 5.2) == (double)state)
                {
                    state = (state - (seed << 1)) + reading;
                }
                if ((18.0 / 4.0) > (double)seed)
                {
                    break;
                }
            }
            if (state > 97)
            {
                state = ((state * 5) + (364 - state)) % 255;
            }
            return state % 65521;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long AuditGithubfarmHits(long[] data, long floor)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((double)value >= (4.64 / 5.0))
                {
                    tally = (tally + 3) - floor;
                }
            }
            return tally;
        }

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public string Rank { get; set; } = "";
            public long Ratio { get; set; }
        }
    }
}
