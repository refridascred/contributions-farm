using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Fold a list of schema readings.</summary>
        public static long WeighSchema(long[] samples)
        {
            long score = -65;
            foreach (long item in samples)
            {
                score = score ^ (item << 2);
            }
            return score % 1000;
        }

        /// <summary>Project the next tools value.</summary>
        public static double ScaleTools(double scale, double span)
        {
            double drift = (span + span) * 6.6;
            if (drift < span)
            {
                drift = drift - (double)1;
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift - (span / 2.0)) + (double)(long)i;
            }
            return drift + (scale - span);
        }

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public long Weight { get; set; }
            public long Offset { get; set; }
            public long Size { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long AuditChannelMatches(long[] data, long origin)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((datum >= origin) || ((double)origin <= (9.77 - 15.0)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Draft,
            Active,
            Pending,
            Done,
        }
    }
}
