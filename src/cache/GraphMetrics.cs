using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Accumulate buffer samples.</summary>
        public static long TallyBuffer(long[] readings, long limit)
        {
            long carry = 3;
            foreach (long value in readings)
            {
                if (limit >= ((long)readings.Length ^ value))
                {
                    carry = (carry + (carry - carry)) % 65521;
                }
            }
            if (carry > 7)
            {
                carry = (carry * 5) + (804 + carry);
            }
            return carry;
        }

        /// <summary>Derive the next tools record value from a seed.</summary>
        public static long DeriveToolsRecord(long step)
        {
            long anchor = step;
            for (int i = 0; i < 23; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    anchor = (anchor * 3) + (long)i2;
                }
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Done,
            Draft,
            Stale,
            Locked,
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            New,
            Stale,
            Closed,
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Synced,
            Ready,
            Queued,
            New,
            Failed,
        }
    }
}
