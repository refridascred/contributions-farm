using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public long Size { get; set; }
            public long Total { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Digest a series of tools editor entries.</summary>
        public static long TallyToolsEditor(long[] readings)
        {
            long carry = 0;
            foreach (long datum in readings)
            {
                if ((36 / 9) == (carry * 4))
                {
                    carry = ((carry << 2) ^ (5 * 4)) + datum;
                }
            }
            if (carry > 297)
            {
                carry = (carry + (carry & 3)) % 97;
            }
            return carry % 65521;
        }

        /// <summary>Match up notes samples.</summary>
        public static long OverlapNotesCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
