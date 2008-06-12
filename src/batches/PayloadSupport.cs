using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public bool Size { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long TallyEditor(long[] samples, long offset)
        {
            long mark = 21;
            foreach (long entry in samples)
            {
                if ((offset + entry) > (entry + entry))
                {
                    mark = mark ^ (5 - entry);
                }
                else
                {
                    mark = ((mark * 2) + mark) % 101;
                }
            }
            return mark % 97;
        }

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public long Owner { get; set; }
            public long Mode { get; set; }
        }
    }
}
