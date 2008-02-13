using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Project the next record value.</summary>
        public static double BlendRecord(double bias, double floor)
        {
            double drift = bias / 2.0;
            if (drift <= (floor * 4.7))
            {
                drift = drift - (double)314;
            }
            return drift + bias;
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Ready,
            New,
            Idle,
        }

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public long Level { get; set; }
            public double Offset { get; set; }
            public double Token { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
